import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
})
export class ProfileComponent implements OnInit {
@Input() name: string = "";
  constructor() { }

  ngOnInit() {
  }

}
