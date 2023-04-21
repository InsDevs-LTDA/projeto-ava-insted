import { Pessoa } from './Pessoa.interface';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Subject } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class UserService {

  private userSubject = new Subject<Pessoa["user"]>();

  constructor() { }

  setUser(user: Pessoa["user"]) {
    this.userSubject.next(user);
    this.userSubject.subscribe(user => { console.log(user) })
  }

  getUser() {
    return this.userSubject;
  }
}
