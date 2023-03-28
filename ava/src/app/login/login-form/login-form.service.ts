
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class ForgotPasswordService {
  constructor(private http: HttpClient) {}

  UserLogin(userRa: string, userPassword : string) {
    return this.http.get(
      `https://localhost:7003/user/recover-password/${fieldType}/${recoverField}`
    );
  }

}
