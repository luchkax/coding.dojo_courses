import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';


@Component({
  selector: 'app-beta',
  templateUrl: './beta.component.html',
  styleUrls: ['./beta.component.css']
})
export class BetaComponent implements OnInit {

  constructor(private _dataService: DataService) { }

  ngOnInit() {
  }
  

  farmGold(){
    this._dataService.addFarm();
  }

  caveGold(){
    this._dataService.addCave();
  }

  casinoGold(){
    this._dataService.addCasino();
  }

  houseGold(){
    this._dataService.addHouse();
  }
  
}
