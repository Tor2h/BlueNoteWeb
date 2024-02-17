import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Trope } from '../models/Trope';

@Injectable({
  providedIn: 'root',
})
export class TropesService {
  constructor(private http: HttpClient) {}

  public getTropes(): Observable<Trope[]> {
    return this.http.get<Trope[]>('/tropes');
  }

  public createTrope(tropeName: string): Observable<Trope> {
    let trope: Trope = new Trope();
    trope.name = tropeName;
    return this.http.post<Trope>('/tropes', trope, {}).pipe();
  }

  public deleteTrope(id: string): Observable<boolean> {
    const options = id
      ? {
          params: new HttpParams().set('id', id),
        }
      : {};
    return this.http.delete<boolean>('tropes', options);
  }
}
