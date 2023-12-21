import { Component } from '@angular/core';
import { FormGroup, UntypedFormControl, Validators } from '@angular/forms';
import { GenresService } from '../../shared/services/genres.service';

@Component({
  selector: 'app-create-genre-dialog',
  templateUrl: './create-genre-dialog.component.html',
  styleUrls: ['./create-genre-dialog.component.css']
})
export class CreateGenreDialogComponent {
  constructor(private genreService: GenresService) { }

  genreForm = new FormGroup({
    genreName: new UntypedFormControl(null, [
      Validators.required
    ])
  })

  onSubmit() {
    if (this.genreForm.value.genreName) {
      this.genreService.createGenre(this.genreForm.value.genreName).subscribe()
    }
  }
}
