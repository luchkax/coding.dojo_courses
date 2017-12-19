import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';

@Component({
  selector: 'app-gamma',
  templateUrl: './gamma.component.html',
  styleUrls: ['./gamma.component.css']
})
export class GammaComponent implements OnInit {

  constructor(private _dataService: DataService) { }

  logs: string[] = []

  ngOnInit() {
    this.logs = this._dataService.retrieveLog();
  }

  
}
