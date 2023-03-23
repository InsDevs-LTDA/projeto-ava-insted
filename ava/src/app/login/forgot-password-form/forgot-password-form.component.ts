import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { CustomValidations } from '../../validators.component';
import { LoginInterface } from '../login.interface';

@Component({
  selector: 'app-forgot-password-form',
  templateUrl: './forgot-password-form.component.html',
})
export class ForgotPasswordFormComponent implements OnInit {
  forgotPasswordForm!: FormGroup;

  ra = '' as string;
  email = '' as string;
  cpf = '' as string;
  someInputFilled = false as boolean;

  constructor(private formBuilder: FormBuilder) {}

  ngOnInit(): void {
    this.forgotPasswordForm = this.formBuilder.group({
      ra: ['', [Validators.minLength(10)]],
      email: ['', [Validators.email]],
      cpf: ['', [CustomValidations.validateCpf]],
    });
  }

  recoverPassword() {
    const recoverPassword =
      this.forgotPasswordForm.getRawValue() as LoginInterface;
    console.log(CustomValidations.validateCpf);
  }
  verificarInputs(e: KeyboardEvent) {
    if (this.ra != '' || this.email != '' || this.cpf != '') {
      this.someInputFilled = true;
    } else {
      if (this.ra == '' && this.email == '' && this.cpf == '') {
        this.someInputFilled = false;
      }
    }
  }
}
