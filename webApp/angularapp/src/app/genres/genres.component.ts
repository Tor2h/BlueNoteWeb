import { Component, OnInit } from '@angular/core';
import { Genre } from '../shared/models/Genre';
import { GenresService } from '../shared/services/genres.service';

@Component({
  selector: 'app-genres',
  templateUrl: './genres.component.html',
  styleUrls: ['./genres.component.css']
})
export class GenresComponent implements OnInit{
  allGenres: Genre[] = []
  displayedColumns: string[] = ['name']
  constructor(private genresService: GenresService) {

  }
  ngOnInit() {
    this.genresService.getGenres().subscribe(g => {
      this.allGenres = g
      console.log(this.allGenres)
    })
  }
}
