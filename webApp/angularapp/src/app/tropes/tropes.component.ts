import { Component, OnInit } from '@angular/core';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { Trope } from '../shared/models/Trope';
import { TropesService } from '../shared/services/tropes.service';
import { CreateTropeDialogComponent } from './create-trope-dialog/create-trope-dialog.component';

@Component({
  selector: 'app-tropes',
  templateUrl: './tropes.component.html',
  styleUrls: ['./tropes.component.css']
})
export class TropesComponent implements OnInit {
  allTropes: Trope[] = []
  displayedColumns: string[] = ['name', 'delete']
  constructor(private tropesService: TropesService, public dialog: MatDialog) {

  }

  ngOnInit() {
    this.getTropes()
  }

  getTropes() {
    this.tropesService.getTropes().subscribe(t => {
      this.allTropes = t
    })
  }

  createTrope() {
    const dialogRef = this.dialog.open(CreateTropeDialogComponent, {
      data: { name: "", id: "" }
    }).afterClosed().subscribe(d => {
      this.getTropes()
    })
  }

  deleteTrope(id: string) {
    this.tropesService.deleteTrope(id).subscribe(t => {
      this.getTropes()
    })
  }
}
