import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common'

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

  errorMessage: boolean | string = false



  logowanie() {
    if (this.formData.username.toLowerCase() === 'user' && this.formData.password.toLowerCase() === 'pw') {
      console.log("Zalogowano");
      this.errorMessage = false
      console.log(this.errorMessage)

    } else {
      console.log("error");
      this.errorMessage = "Błąd Logowania"
      console.log(this.errorMessage)
    }
  }

}
