import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { CreateBookComponent } from '../create-book/create-book.component';
import { Book } from '../shared/models/Book';
import { BooksService } from '../shared/services/books.service';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent implements OnInit{
  allBooks: Book[] = []
  displayedColumns: string[] = ['author', 'aaName', 'series', 'ownedOrWish', 'status', 'score', 'comment', 'tropes', 'genres']
  constructor(private booksService: BooksService, public dialog: MatDialog) {

  }
  ngOnInit() {
    this.getBooks()
  }

  getBooks() {
    this.booksService.getBooks().subscribe(b => {
      this.allBooks = b
    })
  }

  createBook() {
    const dialogRef = this.dialog.open(CreateBookComponent)
      .afterClosed().subscribe(d => {
        if (d) {
          this.getBooks()
        }
      })
  }
}
