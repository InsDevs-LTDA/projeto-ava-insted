import { UserService } from 'app/autentication/user/user.service';
import { Component, OnInit } from '@angular/core';
import { Pessoa } from 'app/autentication/user/Pessoa.interface';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
})
export class ProfileComponent implements OnInit {
  user$ = this.userService.getUser();

  constructor(private userService: UserService) {

  }

  ngOnInit(): void {

  }

}
