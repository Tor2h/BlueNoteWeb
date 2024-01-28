import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Book } from "../models/Book";

@Injectable({
  providedIn: 'root'
})
export class BooksService {

  constructor(private http: HttpClient) {
  }

  public getBooks(): Observable<Book[]> {
    return this.http.get<Book[]>("/books")
  }

  public createBook(book: Book): Observable<Book> {
    console.log(book)
    return this.http.post<Book>("/books", book, {}).pipe()
  }

}
