import { Component, OnInit } from '@angular/core';
import { NumbersService } from '../numbers.service';


@Component({
  selector: 'app-beta',
  templateUrl: './beta.component.html',
  styleUrls: ['./beta.component.css']
})
export class BetaComponent implements OnInit {
  numbers: number[] = [];  

  constructor(private _dataService: NumbersService) { }

  ngOnInit() {
    this.numbers = this._dataService.retrieveNumbers2();
  }

  pushTwo(){
    this._dataService.addNumber2();
  }

}
