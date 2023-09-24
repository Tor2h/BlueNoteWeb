import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TropesComponent } from './tropes.component';

describe('TropesComponent', () => {
  let component: TropesComponent;
  let fixture: ComponentFixture<TropesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TropesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TropesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
