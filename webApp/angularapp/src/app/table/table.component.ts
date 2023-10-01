import { Component, OnInit } from '@angular/core';
import { Book } from '../shared/models/Book';
import { BooksService } from '../shared/services/books.service';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.css']
})
export class TableComponent implements OnInit{
  allBooks: Book[] = []
  displayedColumns: string[] = ['Author']
  constructor(private booksService: BooksService) {

  }
  ngOnInit() {
    this.booksService.getBooks().subscribe(b => this.allBooks = b)
  }
}
