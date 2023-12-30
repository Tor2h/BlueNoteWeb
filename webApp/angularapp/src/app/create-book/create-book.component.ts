import { Component } from '@angular/core';
import { FormGroup, UntypedFormControl, Validators } from '@angular/forms';
import { BooksService } from '../shared/services/books.service';

@Component({
  selector: 'app-create-book',
  templateUrl: './create-book.component.html',
  styleUrls: ['./create-book.component.css']
})
export class CreateBookComponent {
  constructor(private bookService: BooksService) { }

  bookForm = new FormGroup({
    aaName: new UntypedFormControl(null, Validators.required),
    author: new UntypedFormControl(null, Validators.required),
    series: new UntypedFormControl(null),
    ownedOrWish: new UntypedFormControl(null, Validators.required),
    status: new UntypedFormControl(null, Validators.required),
    score: new UntypedFormControl(null),
    comment: new UntypedFormControl(null),
    tropes: new UntypedFormControl(null),
    genres: new UntypedFormControl(null)
  })

  onSubmit() {
    //this.bookService
  }
}
