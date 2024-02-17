import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, UntypedFormControl, Validators } from '@angular/forms';
import { Book, Score, ScoreDisplay, Status, StatusDisplay } from '../shared/models/Book';
import { Genre } from '../shared/models/Genre';
import { Trope } from '../shared/models/Trope';
import { BooksService } from '../shared/services/books.service';
import { GenresService } from '../shared/services/genres.service';
import { TropesService } from '../shared/services/tropes.service';

@Component({
  selector: 'app-create-book',
  templateUrl: './create-book.component.html',
  styleUrls: ['./create-book.component.css']
})
export class CreateBookComponent implements OnInit {

  allTropes: Trope[] = []
  allGenres: Genre[] = []

  constructor(private bookService: BooksService, private genreService: GenresService, private TropeService: TropesService) { }

  ngOnInit() {
    this.TropeService.getTropes().subscribe(t => this.allTropes= t)
    this.genreService.getGenres().subscribe(g => this.allGenres = g)
  }

  bookForm = new FormGroup({
    aaName: new UntypedFormControl(null, [Validators.required]),
    author: new UntypedFormControl(null, [Validators.required]),
    series: new UntypedFormControl(null),
    ownedOrWish: new UntypedFormControl(null),
    status: new UntypedFormControl(null, [Validators.required]),
    score: new UntypedFormControl(null),
    comment: new UntypedFormControl(null),
    //tropes: new UntypedFormControl(null),
    tropes: new FormControl<Trope[]>([]),
    genres: new FormControl<Genre[]>([])
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
    let book: Book = {
      aaName: this.bookForm.value.aaName,
      author: this.bookForm.value.author,
      series: this.bookForm.value.series,
      ownedOrWish: this.bookForm.value.ownedOrWish,
      status: this.bookForm.value.status,
      score: this.bookForm.value.score,
      comment: this.bookForm.value.comment,
      tropes: this.bookForm.value.tropes,
      genres: this.bookForm.value.genres

    }
    console.log("here::")
    console.log(book)
    book.aaName = this.bookForm.value.aaName
    this.bookService.createBook(book).subscribe(result => {
      console.log(result)
    })
  }
}
