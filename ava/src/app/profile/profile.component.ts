import { UserService } from '../autentication/user/user.service';
import { Component } from '@angular/core';
import { Pessoa } from '../autentication/user/Pessoa.interface';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
})
export class ProfileComponent {
  user = null as Pessoa["user"];

  constructor(private userService: UserService) {

  }

  ngOnInit() {

    console.log(this.user, "aff");
    this.userService.getUser().subscribe(user => {
      this.user = user;
    });
  }
}
