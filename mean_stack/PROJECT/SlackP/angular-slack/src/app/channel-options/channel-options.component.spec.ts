import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ChannelOptionsComponent } from './channel-options.component';

describe('ChannelOptionsComponent', () => {
  let component: ChannelOptionsComponent;
  let fixture: ComponentFixture<ChannelOptionsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ChannelOptionsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ChannelOptionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
