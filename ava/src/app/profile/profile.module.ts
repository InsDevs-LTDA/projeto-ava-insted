import { MatIconModule } from '@angular/material/icon';
import { AutenticationService } from './../autentication/autentication.service';
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AsyncPipe } from '@angular/common';
import { ProfileComponent } from './profile.component';
import { UserService } from 'app/autentication/user/user.service';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';

@NgModule({
  declarations: [ProfileComponent],
  imports: [CommonModule, RouterModule, MatSlideToggleModule, MatIconModule],
  exports: [ProfileComponent],
  providers: [UserService, AutenticationService]
})
export class ProfileModule { }
