import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSidenavModule } from '@angular/material/sidenav';
import { TableComponent } from './table/table.component';
import { MatTabsModule } from '@angular/material/tabs';
import { TropesComponent } from './tropes/tropes.component';
import { GenresComponent } from './genres/genres.component';
import { MatTableModule } from '@angular/material/table';
import { MatDialogModule } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { CreateTropeDialogComponent } from './tropes/create-trope-dialog/create-trope-dialog.component';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';

@NgModule({
  declarations: [
    AppComponent,
    TableComponent,
    TropesComponent,
    GenresComponent,
    CreateTropeDialogComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, BrowserAnimationsModule, MatSidenavModule,
    MatTabsModule,
    MatTableModule,
    MatDialogModule,
    MatButtonModule,
    MatIconModule,
    MatInputModule,
    MatFormFieldModule,

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
