import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { LoginInterface } from '../login.interface';
@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
})
export class LoginFormComponent implements OnInit {
  loginForm!: FormGroup; //É estânciado no OnInit

  constructor(private formBuilder: FormBuilder) {}
  ngOnInit(): void {
    this.loginForm = this.formBuilder.group({
      ra: ['', [Validators.required, Validators.minLength(10)]],
      senha: ['', [Validators.required]],
    });
  }

  logar() {
    const logar = this.loginForm.getRawValue() as LoginInterface;
  }

  toggleIcon(event: MouseEvent) {
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
