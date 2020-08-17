import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GetMyGroupsComponent } from './get-my-groups.component';

describe('GetMyGroupsComponent', () => {
  let component: GetMyGroupsComponent;
  let fixture: ComponentFixture<GetMyGroupsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GetMyGroupsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GetMyGroupsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
