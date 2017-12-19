import { Component, OnInit } from '@angular/core';
import { NumbersService } from '../numbers.service';

@Component({
  selector: 'app-alpha',
  templateUrl: './alpha.component.html',
  styleUrls: ['./alpha.component.css']
})
export class AlphaComponent implements OnInit {

  numbers: number[] = [];

  constructor(private _dataService: NumbersService) { }

  ngOnInit() {
    this.numbers = this._dataService.retrieveNumbers1();
  }

  pushOne(){
    this._dataService.addNumber1();
  }

}
