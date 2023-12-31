import { Component } from '@angular/core';
import { FormGroup, UntypedFormControl, Validators } from '@angular/forms';
import { Status, StatusDisplay, Score, ScoreDisplay } from '../shared/models/Book';
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

  statusOption: StatusDisplay[] = [
    {key: Status.NotStarted, value: 'Not started'},
    {key: Status.CurrentlyReading, value: 'Currently reading'},
    {key: Status.Read, value: 'Read'},
    {key: Status.WantToReadSoon, value: 'Want to read soon'}
  ]

  scoreOption: ScoreDisplay[] = [
    { key: Score.One, value: '⭐' },
    { key: Score.Two, value: '⭐⭐' },
    { key: Score.Three, value: '⭐⭐⭐' },
    { key: Score.Four, value: '⭐⭐⭐⭐' },
    { key: Score.Five, value: '⭐⭐⭐⭐⭐' }
  ]

  onSubmit() {
    //this.bookService
  }
}
