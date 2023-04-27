import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MateriasComponent } from './materias/materias.component';
import { AppModule } from 'app/app.module';

@NgModule({
  imports: [CommonModule],
  exports: [HomeModule],
  declarations: [MateriasComponent]
})
export class HomeModule { }
