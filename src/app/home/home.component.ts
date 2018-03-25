import { Component, OnInit } from '@angular/core';
import { finalize } from 'rxjs/operators';

import { QuoteService } from './quote.service';
import { FrmsService } from '@app/home/frms.service';
import { HomeModel } from '@app/home/home-model.interface';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  quote: string;
  isLoading: boolean;
  isLoadingModel: boolean;
  public homeModel: HomeModel;

  constructor(private quoteService: QuoteService, private frmsService: FrmsService) { }

  ngOnInit() {
    this.isLoading = true;
    this.quoteService.getRandomQuote({ category: 'dev' })
      .pipe(finalize(() => { this.isLoading = false; }))
      .subscribe((quote: string) => { this.quote = quote; });

      this.isLoadingModel = true;
      this.frmsService.getHomeModel().pipe(finalize(() => { this.isLoadingModel = false; })).subscribe((homeModel: HomeModel) => {
        this.homeModel = homeModel;
      });
  }

}
