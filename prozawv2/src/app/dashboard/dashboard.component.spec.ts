import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DashboardComponent } from './dashboard.component';

import { MenuComponent } from '../menu/menu.component';

import { AuthService } from '../auth.service';

import { RouterTestingModule } from '@angular/router/testing';
import { NO_ERRORS_SCHEMA } from '@angular/core';

let menuComponent: MenuComponent

describe('DashboardComponent', () => {

  let component: DashboardComponent;

  let fixture: ComponentFixture<DashboardComponent>;

  let authService: AuthService;

  let menuComponent: MenuComponent;




  beforeEach(() => {

    TestBed.configureTestingModule({

      declarations: [],

      providers: [AuthService],

      imports: [RouterTestingModule, DashboardComponent, MenuComponent],


    });



    fixture = TestBed.createComponent(DashboardComponent);

    component = fixture.componentInstance;

    authService = TestBed.inject(AuthService);



    authService.login(); // Zasymuluj zalogowanie

  });



  it('should create', () => {

    expect(component).toBeTruthy();

  });



  it('should display the menu after logging in', () => {

    const menu = fixture.debugElement.nativeElement.querySelector('app-menu');
    fixture.detectChanges(); // Zaktualizuj widok
    expect(menu).toBeTruthy();


  });



  it('should hide the menu after logging out', () => {

    const authService = TestBed.inject(AuthService);
    authService.logout();
    fixture.detectChanges(); // Zaktualizuj widok
    expect(authService.isLoggedIn).toBeFalse();
  });
});





