import { Component, OnInit } from '@angular/core';
import { DataService } from './../data.service';
import { Product } from './../product';
import { Router } from '@angular/router';

@Component({
  selector: 'app-new',
  templateUrl: './new.component.html',
  styleUrls: ['./new.component.css']
})
export class NewComponent implements OnInit {
  newProduct: Product = new Product();
  products: Array<Product>;

  constructor(
              private _dataService: DataService,
              private _router: Router
              ) {
                this._dataService.productsObservable.subscribe( (products) => {
                  this.products = products;
                });
               }

  ngOnInit() {
    this.newProduct = new Product();
  }

  create() {
    this.products.push(this.newProduct);
    this._dataService.updateProducts(this.products);
    this.newProduct = new Product();
    this._router.navigate(['/products']);
  }

}
