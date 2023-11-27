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
  displayedColumns: string[] = ['name']
  trope: Trope | undefined
  constructor(private tropesService: TropesService, public dialog: MatDialog) {

  }

  ngOnInit() {
    this.tropesService.getTropes().subscribe(t => {
      this.allTropes = t
    })
  }

  createTrope() {
    const dialogRef = this.dialog.open(CreateTropeDialogComponent, {
      data: { name: "", id: "" }
    })
    dialogRef.afterClosed().subscribe(result => {
      console.log(result)

      this.tropesService.createTrope(result.name)
    })
  }
}
