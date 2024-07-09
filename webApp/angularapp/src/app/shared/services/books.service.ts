import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Book } from "../models/Book";

@Injectable({
  providedIn: "root",
})
export class BooksService {
  constructor(private http: HttpClient) {}

  public getBooks(): Observable<Book[]> {
    const books = this.http.get<Book[]>("/books");
    return books;
  }

  public createBook(book: Book): Observable<boolean> {
    console.log(book);
    return this.http.post<boolean>("/books", book, {});
  }

  public updateBook(book: Book): Observable<Book> {
    return this.http.patch<Book>("/books", book, {});
  }
}
