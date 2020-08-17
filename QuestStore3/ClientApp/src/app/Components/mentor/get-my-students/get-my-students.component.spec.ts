import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GetMyStudentsComponent } from './get-my-students.component';

describe('GetMyStudentsComponent', () => {
  let component: GetMyStudentsComponent;
  let fixture: ComponentFixture<GetMyStudentsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GetMyStudentsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GetMyStudentsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
