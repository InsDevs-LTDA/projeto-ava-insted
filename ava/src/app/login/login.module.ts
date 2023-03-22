import { LoginComponent } from './login.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginFormComponent } from './login-form/login-form.component';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [LoginComponent, LoginFormComponent],
  imports: [CommonModule, RouterModule],
})
export class LoginModule {}
