import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { TropesService } from '../../shared/services/tropes.service';

@Component({
  selector: 'app-create-trope-dialog',
  templateUrl: './create-trope-dialog.component.html',
  styleUrls: ['./create-trope-dialog.component.css']
})
export class CreateTropeDialogComponent {
  constructor(private tropeService: TropesService) {}

  tropeForm = new FormGroup({
    tropeName: new FormControl<string>('', [
      Validators.required
    ])
  })

  onSubmit() {
    if (this.tropeForm.value.tropeName) {
      this.tropeService.createTrope(this.tropeForm.value.tropeName).subscribe()
    }
  }

}
