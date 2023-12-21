import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Genre } from "../models/Genre";

@Injectable({
  providedIn: 'root'
})
export class GenresService {
  constructor(private http: HttpClient) {
  }
  public getGenres(): Observable<Genre[]> {
    return this.http.get<Genre[]>("/genres")
  }

  public createGenre(genreName: string): Observable<Genre> {
    let genre: Genre = new Genre
    genre.name = genreName
    return this.http.post<Genre>("/genres", genre, {}).pipe()
  }

  public deleteGenre(id: string): Observable<boolean> {
    const options = id ? {
      params: new HttpParams().set('id', id)
    } : {}
    return this.http.delete<boolean>("genres", options)
  }
}
