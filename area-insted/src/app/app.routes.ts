import { Routes, RouterModule } from '@angular/router';
import { LoginPage } from './login/login.page';

export const routes: Routes = [
  {
    path: '',
    redirectTo: 'login',
    pathMatch: 'full',
  }, {
    path: 'login',
    component: LoginPage,
  },
];

export const LoginRoutes = RouterModule.forChild(routes);
