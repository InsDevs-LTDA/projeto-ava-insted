import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
// import function to register Swiper custom elements
import { register } from 'swiper/element/bundle';
// register Swiper custom elements
register();

@NgModule({
  declarations: [],
  imports: [
    CommonModule,]
})
export class CustomSwiperModule { }
