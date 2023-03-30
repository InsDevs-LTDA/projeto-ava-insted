import { Routes, RouterModule } from '@angular/router';
import { LoginPage } from './login.page';
import { LoginFormComponent } from './login-form/login.form';

export const routes: Routes = [
  {
    path: '',
    component: LoginPage,
    children: [
      {
        path: '',
        component: LoginFormComponent
      },
      {
        path: 'recuperar-senha',
        component: LoginFormComponent
      },

    ],
  },
  {
    path: '',
    redirectTo: '/login',
    pathMatch: 'full',
  },
];

export const LoginRoutes = RouterModule.forChild(routes);
