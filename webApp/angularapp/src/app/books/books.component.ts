import { Component } from '@angular/core';
import { Book } from '../shared/models/Book';
import { BooksService } from '../shared/services/books.service';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrl: './books.component.css',
})
export class BooksComponent {
  totalBooks = 0;
  books: Book[] = [];
  constructor(private booksService: BooksService) {
    this.booksService.getBooks().subscribe((b) => {
      this.books = b;
      this.totalBooks = b.length;
    });
  }
}
