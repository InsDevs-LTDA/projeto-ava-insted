import { FormGroup, FormBuilder } from '@angular/forms';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, catchError, map } from 'rxjs';
import { LoginInterface, ResponseInterface } from '../login.interface';


@Injectable({
  providedIn: 'root',
})
export class LoginService {

  private apiUrl = "https://localhost:7003/"

  constructor(private http: HttpClient) { }

  login(loginRequest: LoginInterface): Observable<ResponseInterface> {
    const json = {
      "ra": loginRequest.ra as string,
      "password": loginRequest.password as string
    }
    const loginUrl = `${this.apiUrl}login`;
    return this.http.post<ResponseInterface>(`${loginUrl}`, json)
  }

  logout(): void {
    localStorage.removeItem('token'); // Remove o token armazenado na memória
  }

}
