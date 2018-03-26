import { Component, OnInit } from '@angular/core';
import { finalize } from 'rxjs/operators';

import { QuoteService } from './quote.service';
import { ReferenceDataService } from '@app/shared/services/reference-data.service';
import { FilingRequestStatus } from '@app/home/filing-request-status.interface';
import { HomeModel } from '@app/home/home-model.interface';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  public quote: string;
  public isLoading: boolean;
  public isLoadingModel: boolean;
  public homeModel: HomeModel;

  constructor(private quoteService: QuoteService, private referenceDataService: ReferenceDataService) {}

  ngOnInit() {
    this.isLoading = true;
    this.quoteService.getRandomQuote({ category: 'dev' })
      .pipe(finalize(() => { this.isLoading = false; }))
      .subscribe((quote: string) => { this.quote = quote; });

      this.isLoadingModel = true;
      this.referenceDataService.getFilingRequestStauses().pipe(finalize(() => { this.isLoadingModel = false; })).subscribe((filingRequestStatuses: FilingRequestStatus[]) => {
        this.homeModel.filingRequestStatuses = filingRequestStatuses;
      });
  }

}
