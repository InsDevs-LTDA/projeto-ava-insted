import { NgModule } from '@angular/core';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';

const MODULES = [MatProgressSpinnerModule]

@NgModule
  ({
    imports: [MODULES],
    exports: [MODULES]
  })
export class MaterialModule { }
