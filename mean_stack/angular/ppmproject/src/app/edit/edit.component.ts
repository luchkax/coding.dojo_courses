import { Component, OnInit } from '@angular/core';
import { DataService } from './../data.service';
import { Router, ActivatedRoute } from '@angular/router';
import { Product } from '../Product';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit {
  products: Array<Product>;
  product: Product;

  constructor(
    private _route: ActivatedRoute,
    private _dataService: DataService,
    private _router: Router
  ) { 
    this._dataService.productsObservable
    .subscribe( (products) => {
      this.products = products;
    });

    this._route.params.subscribe( param => {
      for(let idx = 0; idx < this.products.length; idx++) {
        if (this.products[idx].id == param.id) {
          this.product = this.products[idx];
          break
        }
      }
    })
  }

  ngOnInit() {
    this._dataService.updateProducts(this.products);
    this._router.navigate(['/products'])
  }
}
