import { Component, OnInit } from '@angular/core';
import { NumbersService } from '../numbers.service';


@Component({
  selector: 'app-diff',
  templateUrl: './diff.component.html',
  styleUrls: ['./diff.component.css']
})
export class DiffComponent implements OnInit {

  sum: number[] = [];

  constructor(private _dataService: NumbersService) { }

  ngOnInit() {
    this.sum = this._dataService.retrieveSum();
  }

  minus() {
    this._dataService.different();
  }



}
