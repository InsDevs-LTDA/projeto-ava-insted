import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AsyncPipe } from '@angular/common';
import { ProfileComponent } from './profile.component';
import { UserService } from 'app/autentication/user/user.service';

@NgModule({
  declarations: [ProfileComponent],
  imports: [CommonModule, RouterModule],
  exports: [ProfileComponent],
  providers: [UserService]
})
export class ProfileModule { }
