import { HttpClient } from "@angular/common/http";
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
}
