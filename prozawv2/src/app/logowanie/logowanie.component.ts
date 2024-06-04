import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { AuthService } from '../auth.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-logowanie',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './logowanie.component.html',
  styleUrl: './logowanie.component.css'
})
export class LogowanieComponent {
  formData = {
    username: '',
    password: ''
  };

  errorMessage: boolean | string = false;
  constructor(private authService: AuthService, private router: Router) { }




  logowanie() {
    if (this.formData.username.toLowerCase() === 'user' && this.formData.password.toLowerCase() === 'pw') {
      console.log("Zalogowano");
      this.errorMessage = false
      console.log(this.errorMessage)
      this.login();
      console.log(this.authService.isLoggedIn)
    }
    else {
      console.log("error");
      this.errorMessage = "Błąd Logowania"
      console.log(this.errorMessage)
    }
  }
  login() {
    this.authService.login();
    this.router.navigate(['/dashboard'])
  }

}
