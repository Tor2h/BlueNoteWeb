import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Trope } from "../models/Trope";

@Injectable({
  providedIn: 'root'
})
export class TropesService {
  constructor(private http: HttpClient) {
    
  }
  public getTropes(): Observable<Trope[]> {
    return this.http.get<Trope[]>("/tropes")
  }
  public createTrope(tropeName: string): Observable<Trope> {
    return this.http.post<Trope>("/tropes", tropeName)
  }

}
