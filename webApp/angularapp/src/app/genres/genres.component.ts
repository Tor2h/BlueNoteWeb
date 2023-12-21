import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Genre } from '../shared/models/Genre';
import { GenresService } from '../shared/services/genres.service';
import { CreateGenreDialogComponent } from './create-genre-dialog/create-genre-dialog.component';

@Component({
  selector: 'app-genres',
  templateUrl: './genres.component.html',
  styleUrls: ['./genres.component.css']
})
export class GenresComponent implements OnInit{
  allGenres: Genre[] = []
  displayedColumns: string[] = ['name', 'delete']
  constructor(private genresService: GenresService, public dialog: MatDialog) {

  }
  ngOnInit() {
    this.getGenres()
  }

  getGenres() {
    this.genresService.getGenres().subscribe(g => {
      this.allGenres = g
    })
  }

  createGenre() {
    const dialogRef = this.dialog.open(CreateGenreDialogComponent, {
      data: { name: "", id: "" }
    }).afterClosed().subscribe(d => {
      this.getGenres()
    })
  }
  deleteGenre(id: string) {
    this.genresService.deleteGenre(id).subscribe(g => {
      this.getGenres()
    })
  }
}
