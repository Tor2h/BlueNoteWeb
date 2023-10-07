import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateTropeDialogComponent } from './create-trope-dialog.component';

describe('CreateTropeDialogComponent', () => {
  let component: CreateTropeDialogComponent;
  let fixture: ComponentFixture<CreateTropeDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateTropeDialogComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CreateTropeDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
