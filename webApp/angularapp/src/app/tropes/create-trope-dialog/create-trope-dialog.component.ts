import { Component, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Trope } from '../../shared/models/Trope';
import { TropesService } from '../../shared/services/tropes.service';

@Component({
  selector: 'app-create-trope-dialog',
  templateUrl: './create-trope-dialog.component.html',
  styleUrls: ['./create-trope-dialog.component.css']
})
export class CreateTropeDialogComponent {

  constructor(
    public dialogRef: MatDialogRef<CreateTropeDialogComponent>,
    @Inject(MAT_DIALOG_DATA) public trope: Trope,
  ) {
  }

  onNoClick(): void {
    this.dialogRef.close()
  }

  //createTrope(tropeNameInput: string) {
  //  console.log("input::")
  //  console.log(tropeNameInput)
  //  console.log("attribute::")
  //  console.log(this.tropeName)
  //  this.tropesService.createTrope(this.tropeName).subscribe()
  //}
}
