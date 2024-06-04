import { Injectable } from '@angular/core';
import { Router } from '@angular/router';


@Injectable({
  providedIn: 'root'
})
export class AuthService {
  isLoggedIn = false;

  login(){
    this.isLoggedIn = true;
  }

  logout(){
    this.isLoggedIn = false;
   
  }
}
