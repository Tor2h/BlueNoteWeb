import { Component } from '@angular/core';
import { GenresService } from '../../shared/services/genres.service';

@Component({
  selector: 'app-create-genre-dialog',
  templateUrl: './create-genre-dialog.component.html',
  styleUrls: ['./create-genre-dialog.component.css']
})
export class CreateGenreDialogComponent {
  constructor(private genreService: GenresService) { }

  genreForm = new Form
}
