import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GetBonusComponent } from './get-bonus.component';

describe('GetBonusComponent', () => {
  let component: GetBonusComponent;
  let fixture: ComponentFixture<GetBonusComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GetBonusComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GetBonusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
