import { Pessoa } from './Pessoa.interface';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class UserService {

  private userSubject = new BehaviorSubject<Pessoa["user"]>(null);

  constructor() { this.userSubject.subscribe(user => {
    console.log("quando o user atualiza : " + user?.nrCpf);
  });}

  setUser(user: Pessoa["user"]) {
    console.log("chamado o setUser", user?.nmUser)
    this.userSubject.next(user);
  }

  getUser() {
    return this.userSubject.asObservable();
  }
}
