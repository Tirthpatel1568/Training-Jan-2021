import { Component, OnInit } from '@angular/core';
import {AppComponent} from '../app.component'
@Component({
  selector: 'app-custom-directives',
  templateUrl: './custom-directives.component.html',
  styleUrls: ['./custom-directives.component.css']
})
export class CustomDirectivesComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
color:string;
}