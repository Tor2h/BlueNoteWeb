import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { PageComponent } from './page/page.component';
import { MatSidenavModule } from '@angular/material/sidenav';

@NgModule({
  declarations: [
    AppComponent,
    PageComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, BrowserAnimationsModule, MatSidenavModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
