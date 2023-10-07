import { Component } from '@angular/core';
import { TropesService } from '../../shared/services/tropes.service';

@Component({
  selector: 'app-create-trope-dialog',
  templateUrl: './create-trope-dialog.component.html',
  styleUrls: ['./create-trope-dialog.component.css']
})
export class CreateTropeDialogComponent {
  tropeName: string = ""
  constructor(private tropesService: TropesService) { }
  createTrope() {
    this.tropesService.createTrope(this.tropeName)
  }
}
