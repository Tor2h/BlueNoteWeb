import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Book, Score, Status } from '../shared/models/Book';
import { BooksService } from '../shared/services/books.service';

@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css'],
})
export class BooksComponent implements OnInit {
  allBooks: Book[] = [];
  constructor(private booksService: BooksService, public dialog: MatDialog) {}

  ngOnInit(): void {
    this.getBooks();
  }

  getBooks() {
    this.booksService.getBooks().subscribe((b) => {
      this.allBooks = b;
    });
  }

  updateBook() {
    console.log('UPDATE');
  }

  getOwnedString(ownedOrWish: boolean): string {
    switch (ownedOrWish) {
      case true:
        return 'Owned';
      case false:
        return 'Dont own';
    }
  }

  getStatusString(status: Status): string {
    switch (status) {
      case Status.NotStarted:
        return 'Not started';
      case Status.CurrentlyReading:
        return 'Currently reading';
      case Status.Read:
        return 'Read';
      case Status.WantToReadSoon:
        return 'Want to Read Soon';
    }
  }

  getScoreString(score: Score): string {
    switch (score) {
      case Score.One:
        return '⭐';
      case Score.Two:
        return '⭐⭐';
      case Score.Three:
        return '⭐⭐⭐';
      case Score.Four:
        return '⭐⭐⭐⭐';
      case Score.Five:
        return '⭐⭐⭐⭐⭐';
    }
  }
}
