
import { AutenticationService } from './../../autentication/autentication.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { UserService } from 'app/autentication/user/user.service';
import { LoadingService } from 'app/services/loading.service';
import { finalize } from 'rxjs';
@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
})
export class LoginFormComponent implements OnInit {
  loginForm!: FormGroup; //É estânciado no OnInit

  ra = '' as string;
  password = '' as string;

  constructor(
    private authService: AutenticationService,
    private formBuilder: FormBuilder,
    private router: Router,
    private userService: UserService
  ) { }

  ngOnInit(): void {
    this.loginForm = this.formBuilder.group({
      ra: ['', [Validators.required, Validators.minLength(10)]],
      password: ['', [Validators.required]],
    });
  }
  Login() {
    const loginRequest = {
      "login": this.loginForm.get('ra')?.value,
      "password": this.loginForm.get('password')?.value
    }
    this.authService.auth(loginRequest).subscribe({
      next: (response) => {
        if (response.success) {
          console.log(response.message)
          this.userService.setUser(response.user);
          this.router.navigate(['/perfil']);

        } else {
          throw new Error(response.message);
        }
      },
      error: (error) => {
        console.error('Failed to login', error);
      }
    }
    // finalize: () => { }
    );
  }

  ToggleIcon(event: MouseEvent) {
    event.preventDefault(); // Interrompe o comportamento padrão do navegador
    let password = document.getElementById('password') as HTMLInputElement;
    let icon = document.getElementById('icon');
    if (password?.type === 'password') {
      password.setAttribute('type', 'text');
      icon?.classList?.add('hide');
    } else {
      password?.setAttribute('type', 'password');
      icon?.classList?.remove('hide');
    }
  }
}
